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
    public class ModificationModularHead : Template
    {
        public static readonly Guid ID = Guid.Parse("707b6000-614f-4043-b2ce-55784da58ff0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Modular Head",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa280a09-6cba-41ce-bd99-92bc1493657a"), Type = TextBlockType.Text, Text = $"You've constructed a multi-purpose, adjustable striking surface for your weapon, or you've made special ammunition you can swiftly alter. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("modular", Traits.Instances.Modular.ID)} (B, P, or S) trait for bludgeoning, piercing, and slashing. When you {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to use the {ToMarkdownLink<Models.Entities.Trait>("modular", Traits.Instances.Modular.ID)} trait, you can also choose to give the weapon the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} trait if it doesn't currently have it, or to remove that trait if it's currently nonlethal." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e831f6be-146e-4e97-99fa-5e2f4f3fae47"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
