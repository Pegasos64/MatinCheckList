using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinCheckList
{

    public enum taskState
    {
        TEHTY, KESKEN, LUOTU, PERUTTU, POISTETTU
    }
    public enum taskImportance
    {
        HIGH, MEDIUM, LOW
    }

    class Tehtava
    {
        public taskState state;
        public string topic;
        public string information;
        public string assignee;
        public taskImportance importance;

        public Tehtava(string topic)
        {
            this.state = taskState.LUOTU;
            this.topic = topic;
            this.assignee = "not assigned";
            this.importance = taskImportance.MEDIUM;
        }
        public Tehtava(string topic, string information, string assignee, taskImportance importance)
        {
            this.state = taskState.LUOTU;
            this.topic = topic;
            this.information = information;
            this.assignee = assignee;
            this.importance = importance;
        }
    }
}
