using System;
using System.Text.Json;

using FluentAssertions;
using GitLabApiClient.Models;
using GitLabApiClient.Models.Projects.Responses;
using GitLabApiClient.Models.ToDoList.Responses;
using Xunit;

namespace GitLabApiClient.Test.Internal;

public class ToDoListTest
{
    private class MockToDo : IToDo
    {
        public int? Id { get; set; } = 1;
        public Project Project { get; set; } = new();
        public Assignee Author { get; set; } = new();
        public ToDoActionType? ActionType { get; set; } = null;
        public ToDoTargetType? TargetType { get; set; } = null;
        public string TargetUrl { get; set; } = "";
        public string Body { get; set; } = "";
        public ToDoState? State { get; set; } = null;
        public string CreatedAt { get; set; } = "";
    }

    [Fact]
    public void NullToDoTargetTypeThrows()
    {
        var mockToDo = new MockToDo();
        string serializedToDo = JsonSerializer.Serialize(mockToDo);

        Action action = () => JsonSerializer.Deserialize<IToDo>(serializedToDo);

        action.Should().Throw<JsonException>();
    }

    [Fact]
    public void UnknownToDoTargetTypeThrows()
    {
        var mockToDo = new MockToDo();
        string serializedToDo = JsonSerializer.Serialize(mockToDo);

        serializedToDo = serializedToDo.Replace("\"TargetType\":null", "\"TargetType\":\"unknownType\"");

        Action action = () => JsonSerializer.Deserialize<IToDo>(serializedToDo);

        action.Should().Throw<JsonException>();
    }

    [Fact]
    public void MissingToDoTargetTypeThrows()
    {
        var mockToDo = new MockToDo();
        string serializedToDo = JsonSerializer.Serialize(mockToDo);

        serializedToDo = serializedToDo.Replace("\"TargetType\":null,", "");

        Action action = () => JsonSerializer.Deserialize<IToDo>(serializedToDo);

        action.Should().Throw<JsonException>();
    }
}