﻿
using QuizPlatform.Core.Domain;
using QuizPlatform.Core.Domain.QuestionManagment;

namespace QuizPlatformAPI.Models;
public class QuestionRequestDto 
{
    public string Description { get; set; }
    public Boolean WithTimer { get; set; }
    public int TimerInSeconds { get; set; }
    public Guid CategoryGuid { get; set; }

    public QuestionRequestDto()
    {

    }

    public QuestionRequestDto(Question question)
    {
        Description = question.Description;
        WithTimer = question.WithTimer;
        TimerInSeconds = question.TimerInSeconds;
        CategoryGuid = question.CategoryGuid;
    }
}
 