using LazyTeacher.LazyTeacher.Domain;
using Xunit;
using System;


namespace LazyTeacher.LazyTeacher.test.Domain.entity
{
    public class ActivityTest
    {
        [Fact]
        public void ShouldCreateANewActivity()
        {
            string title = "Math Activity";
            string description = "A challenging math activity.";
            string address = "www.example.com";

            var activity = new Activity(title, description, address);

            Assert.NotNull(activity.Id);
            Assert.Equal(title, activity.Title);
            Assert.Equal(description, activity.Description);
            Assert.Equal(address, activity.Address);
            Assert.True(activity.CreatedAt <= DateTimeOffset.UtcNow);
            Assert.Empty(activity.Tags);
            Assert.Empty(activity.Subjects);
            Assert.Empty(activity.Grades);

        }

        [Fact]
        public void ShouldAddTagToActivity()
        {
            var activity = new Activity("Math Activity", "A math activity", "www.example.com");

            activity.AddTag("Mathematics");

            Assert.Contains("Mathematics", activity.Tags);
        }

        [Fact]
        public void ShouldAddSubjectToActivity()
        {
            var activity = new Activity("Math Activity", "A math activity", "www.example.com");

            activity.AddSubject("Math");

            Assert.Contains("Math", activity.Subjects);
        }

        [Fact]
        public void ShouldAddGradeToActivity()
        {
            var activity = new Activity("Math Activity", "A math activity", "www.example.com");

            activity.AddGrade("1st Grade");

            Assert.Contains("1st Grade", activity.Grades);
        }
    }

}
