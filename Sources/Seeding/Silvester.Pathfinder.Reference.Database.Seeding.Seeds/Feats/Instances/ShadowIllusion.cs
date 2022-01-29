using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowIllusion : Template
    {
        public static readonly Guid ID = Guid.Parse("eb361bfc-d6f1-4dfe-9c5d-37889cbf13f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Illusion",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d5c3bee-e196-405e-8666-81d8ed4555be"), Type = TextBlockType.Text, Text = $"With an artful eye, you shape shadows into illusory forms. You gain the {ToMarkdownLink<Models.Entities.Spell>("shadow illusion", Spells.Instances.ShadowIllusion.ID)} focus spell. Increase the number of Focus Points in your pool by 1. You become an expert in occult spell attack rolls and DCs." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9a457abd-56a2-4e04-9dad-3d1c2c50a835"), Feats.Instances.ShadowMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a717231-aa97-4f46-9474-aebd1aad26b3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
