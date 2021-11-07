using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("a5e05148-5fbf-424b-82f5-a314a246cb22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Breadth",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b447aa6-66b1-4338-a0e7-2c87abded65d"), Type = TextBlockType.Text, Text = "You can cast more arcane spells each day. Increase the spell slots you gain from wizard archetype feats by 1 for each spell level other than your two highest wizard spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ecf2fb31-5be8-4653-8b9a-3ea8360fc6ce"), Feats.Instances.BasicWizardSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60ad8b4e-c1ce-49e9-977a-6a1e2372f3d3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
