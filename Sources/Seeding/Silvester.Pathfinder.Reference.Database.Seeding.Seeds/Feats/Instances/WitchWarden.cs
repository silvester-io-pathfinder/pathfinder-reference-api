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
    public class WitchWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("6a66b816-e2c8-40d5-baff-b9b01dc29afc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch Warden",
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
            yield return new TextBlock { Id = Guid.Parse("ff13619e-dc52-4d66-ac59-ecc4ef343fb2"), Type = TextBlockType.Text, Text = $"~ Access: Kellid ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("4f98e087-4f11-4cb3-af35-4d311379c893"), Type = TextBlockType.Text, Text = $"You and your family have fought long and hard against witches, particularly the winter witches of Irrisen, and you've learned to be wary of their curses and the otherworldly powers their patrons grant. You gain a +1 circumstance bonus to saving throws against curses, and to saving throws against spells cast by a witch or hag. If you roll a success on a saving throw against a curse or a spell cast by a witch or hag, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6183c7c2-abc7-494f-a648-a60a98d5e4b7"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("754f8f4a-f1dc-4355-a3cf-1e1c19ccffb9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
