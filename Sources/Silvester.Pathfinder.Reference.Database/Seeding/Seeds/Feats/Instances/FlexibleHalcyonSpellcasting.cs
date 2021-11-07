using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlexibleHalcyonSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("b4c7a0b2-3ee7-477e-afd2-1d72703a46fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Halcyon Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("7b1a53f9-59e3-4e1f-a4f5-1d013667d787"), Type = TextBlockType.Text, Text = "You broaden your ability to channel your power into halcyon magic. You gain one more common halcyon spell of each level of halcyon spell you can cast other than your highest (you do not gain an additional cantrip). You also gain one additional halcyon spell slot for each level of halcyon spell you can cast, other than the highest." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("425f5a48-3b70-4e37-90d7-e286a56c5f3d"), Feats.Instances.HalcyonSpellcastingInitiate.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d23dbf7-4059-4ea9-9540-e96689ed1b60"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
