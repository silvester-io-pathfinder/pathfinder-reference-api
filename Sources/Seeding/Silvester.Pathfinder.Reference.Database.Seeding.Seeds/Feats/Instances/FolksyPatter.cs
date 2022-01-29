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
    public class FolksyPatter : Template
    {
        public static readonly Guid ID = Guid.Parse("d55c96a9-34d9-4695-bd57-825621ae9a92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Folksy Patter",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e558447-fed2-4874-b65b-6a55cbb7c770"), Type = TextBlockType.Text, Text = $"You are adept at disguising coded messages as folksy idioms. Using slang, jokes, halfling loanwords, and the like, you convey a simple message consisting of three basic words (such as “Danger assassin flee” or “Meet me moonrise”). Your intended listener can attempt a Perception check to discern the message (DC 20 if an ally, DC 15 if a halfling ally, DC 10 if a halfling ally with Folksy Patter). Eavesdroppers can also attempt a Perception check against your Deception DC to discern your meaning. Any bonuses or penalties to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} apply." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b83f851-02c4-4521-bd37-f7f9b01bf167"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
