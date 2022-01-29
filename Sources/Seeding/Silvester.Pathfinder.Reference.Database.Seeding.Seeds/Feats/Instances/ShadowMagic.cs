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
    public class ShadowMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("f913973b-9709-4ee3-a895-f0fce6ca36c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Magic",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73e0fcf0-ae89-40f8-b022-5bffb30a3802"), Type = TextBlockType.Text, Text = $"You gain the ability to fuse and play with shadows by using focus spells specific to shadowcaster. You learn a shadowcaster focus spell of your choice: {ToMarkdownLink<Models.Entities.Spell>("dance of darkness", Spells.Instances.DanceOfDarkness.ID)} or {ToMarkdownLink<Models.Entities.Spell>("shadow jump", Spells.Instances.ShadowJump.ID)}. If you don't already have one, you gain a focus pool of 1 Focus Point, which you can {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} by meditating within an area of dim light or darkness. The rules for focus spells appear on page 300." };
            yield return new TextBlock { Id = Guid.Parse("2b9b6b45-fdc2-40a9-b3fd-3265d7abb58f"), Type = TextBlockType.Text, Text = $"Shadowcaster focus spells are occult spells. You become trained in occult spell attack rolls and spell DCs, and your spellcasting ability for these spells is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1fb10dcf-748c-4640-aa86-94eb60de4cd0"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("102219c7-7307-444e-b60a-8c83e6033162"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
