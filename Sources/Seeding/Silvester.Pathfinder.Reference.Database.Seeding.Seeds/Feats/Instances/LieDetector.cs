using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LieDetector : Template
    {
        public static readonly Guid ID = Guid.Parse("af84bea3-c48e-4b49-bc4f-2e6fa233f866");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lie Detector",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("119294d2-5c52-4fe3-a0b5-2e399cc1903e"), Type = TextBlockType.Text, Text = $"You're adept at noticing the tells of a liar – sweat, flushing, a quavering voice, a quickening pulse. You gain a +1 circumstance bonus to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} and to Perception DCs against attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} to you. When you determine someone is lying to you, you can use their deceit to your advantage to gain a +1 circumstance bonus to the next Deception, Diplomacy, Intimidation, or Performance check you attempt against that creature within the next minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("0eed43e9-2718-4900-9e16-a6a5565c4adc"), or => 
            {
                or.HaveSpecificMethodology(Guid.Parse("bb8a0324-a609-415a-b90e-f6c96cefe3ec"), Methodologies.Instances.Empiricism.ID);
                or.HaveSpecificMethodology(Guid.Parse("e56b8588-b447-4fe0-b7e4-8e67a1bb8aa7"), Methodologies.Instances.Interrogation.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d2d45433-882d-4e07-8ba2-53d7c24222e1"), Traits.Instances.Investigator.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afcedc9b-e6ac-4cd1-accc-0989ba728f6e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
