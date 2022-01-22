using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HammerQuake : Template
    {
        public static readonly Guid ID = Guid.Parse("55a0755d-7fbd-49f6-8a37-137be7614f5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hammer Quake",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69dbe357-6aa9-4594-b69b-bb7542a47c87"), Type = TextBlockType.Text, Text = $"You smash the ground with your weapon, knocking nearby creatures to the ground. Choose a square within your reach, including your own space. If there's a foe in the chosen square, {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that foe with the required weapon. Then attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} every foe in the chosen square plus each square adjacent to that square, ignoring {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}'s requirement that you have a hand free. This counts as three attacks toward your multiple attack penalty, but the penalty doesn't increase until after you've made the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, if any, and all the {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} attempts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f25d558-3f39-49a4-8938-03dd2a67718a"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b214a95e-43fc-4327-9583-20b12025b6f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
