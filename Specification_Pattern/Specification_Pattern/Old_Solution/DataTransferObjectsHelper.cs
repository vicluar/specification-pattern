using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Specification_Pattern.Old_Solution
{
    public static class DataTransferObjectsHelper
    {
        public static List<CourseDTO> GetCourseItems(string cultureCode)
        {
            if (IsSpanishCulture(cultureCode))
            {
                return new List<CourseDTO>
                {
                    new CourseDTO
                    {
                        CourseId = 1,
                        CourseName = "1 Spanish Course",
                        Instructor = "Spanish Teacher 1",
                        Price = 100
                    },
                    new CourseDTO
                    {
                        CourseId = 2,
                        CourseName = "2 Spanish Course",
                        Instructor = "Spanish Teacher 2",
                        Price = 130
                    },
                    new CourseDTO
                    {
                        CourseId = 3,
                        CourseName = "3 Spanish Course",
                        Instructor = "Spanish Teacher 3",
                        Price = 80
                    }
                };
            }

            if (IsFrenchCulture(cultureCode))
            {
                return new List<CourseDTO>
                {
                    new CourseDTO
                    {
                        CourseId = 4,
                        CourseName = "1 French Course",
                        Instructor = "French Teacher 1",
                        Price = 130
                    },
                    new CourseDTO
                    {
                        CourseId = 5,
                        CourseName = "2 French Course",
                        Instructor = "French Teacher 2",
                        Price = 180
                    },
                    new CourseDTO
                    {
                        CourseId = 6,
                        CourseName = "3 French Course",
                        Instructor = "French Teacher 3",
                        Price = 175
                    }
                };
            }

            if (IsCanadianCulture(cultureCode))
            {
                return new List<CourseDTO>
                {
                    new CourseDTO
                    {
                        CourseId = 7,
                        CourseName = "1 Canadian Course",
                        Instructor = "Canadian Teacher 1",
                        Price = 190
                    },
                    new CourseDTO
                    {
                        CourseId = 8,
                        CourseName = "2 Canadian Course",
                        Instructor = "Canadian Teacher 2",
                        Price = 280
                    }
                };
            }

            if (IsSwedishCulture(cultureCode))
            {
                return new List<CourseDTO>
                {
                    new CourseDTO
                    {
                        CourseId = 9,
                        CourseName = "1 Swedish Course",
                        Instructor = "Swedish Teacher 1",
                        Price = 165
                    }
                };
            }

            return new List<CourseDTO>
            {
                new CourseDTO
                {
                    CourseId = 10,
                    CourseName = "1 General Course",
                    Instructor = "General Teacher 1",
                    Price = 90
                }
            };
        }

        private static bool IsSwedishCulture(string cultureCode)
        {
            return cultureCode == "sv";
        }

        public static bool IsCanadianCulture(string cultureCode)
        {
            return cultureCode == "ca";
        }

        private static bool IsFrenchCulture(string cultureCode)
        {
            return cultureCode == "fr";
        }

        private static bool IsSpanishCulture(string cultureCode)
        {
            return cultureCode == "es";
        }
    }
}
