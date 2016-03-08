﻿using System;

namespace StudyAssistInterfaces
{
    public interface IProblem
    {
        String Question { get; set; }
        String Answer { get; set; }

        Byte StudyLevel { get; set; }

        Boolean IsStudy { get; set; }
    }
}