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
    public class CallUponTheBrightness : Template
    {
        public static readonly Guid ID = Guid.Parse("02202abd-90d4-4ed5-a90e-3a8512795b2d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Upon the Brightness",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt an attack roll, skill check, or saving throw while performing the course of action from your augury, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f53b5f1c-aaf6-4186-a48b-ce22a701bfdc"), Type = TextBlockType.Text, Text = $"You gain a +1 status bonus to the triggering check, or a +2 status bonus if the result of the augury was “woe” and you proceeded anyway." };
            yield return new TextBlock { Id = Guid.Parse("05442878-b5ce-47d8-bf8c-4cf0656d22e6"), Type = TextBlockType.Text, Text = $"__You can only use this reaction for the next 30 minutes after casting {ToMarkdownLink<Models.Entities.Spell>("augury", Spells.Instances.Augury.ID)} from the {ToMarkdownLink<Models.Entities.Feat>("Brightness Seeker", Feats.Instances.BrightnessSeeker.ID)} feat.__" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39a8b58e-6567-4ba0-9e55-a8dab6f038f4"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
