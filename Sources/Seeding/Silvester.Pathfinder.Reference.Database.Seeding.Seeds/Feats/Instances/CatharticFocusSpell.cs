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
    public class CatharticFocusSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("2b877762-8110-48af-9aae-7a431f300123");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cathartic Focus Spell",
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
            yield return new TextBlock { Id = Guid.Parse("207071dd-122c-4c00-a24b-8e57584b04c4"), Type = TextBlockType.Text, Text = $"You learn the focus spell listed under your emotion's entry. You can cast it only while in emotional fervor. If you don't already have one, you gain a focus pool of 1 Focus Point, which you can {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} while you use {ToMarkdownLink<Models.Entities.Feat>("Settle Emotions", Feats.Instances.SettleEmotions.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("667450c9-30a8-4836-9c88-dbacd3b1dbfa"), Feats.Instances.CatharticMageDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad74bad9-a01e-4c01-a27c-00668bdecaa5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
