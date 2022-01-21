using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EdgewatchDetectiveDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("a2bfcd85-8331-44a2-9014-aa91181d2be3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Edgewatch Detective Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5f1392b-e1c0-400d-9eab-befb53ce74e7"), Type = TextBlockType.Text, Text = $"You become trained in Society or Thievery; if you are already trained in both of these skills, you instead become trained in a skill of your choice. You can use Perception instead of Survival to {ToMarkdownLink<Models.Entities.SkillAction>("Track", SkillActions.Instances.Track.ID)}, and you gain the {ToMarkdownLink<Models.Entities.Feat>("Experienced Tracker", Feats.Instances.ExperiencedTracker.ID)} skill feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c9905489-10ad-4229-8348-e72542f59d39"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("01f99a77-ddfc-4ea9-a24b-46b0de427f8e"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
                or.HaveSpecificStat(Guid.Parse("57bf2672-2b5b-4bf1-baa7-eccc60bf54d4"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f244df5-9779-4885-9688-bf618deabb4a"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
