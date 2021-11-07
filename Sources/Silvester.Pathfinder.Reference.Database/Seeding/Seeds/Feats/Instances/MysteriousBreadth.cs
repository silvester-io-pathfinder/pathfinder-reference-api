using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MysteriousBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("9d2dbd17-37bb-4a22-878c-593de8c1b8e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mysterious Breadth",
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
            yield return new TextBlock { Id = Guid.Parse("0f32e4bc-eaff-4ca2-bf0a-4e16803e1b62"), Type = TextBlockType.Text, Text = "Increase the number of spells in your repertoire and the number of spell slots you gain from oracle archetype feats by 1 for each spell level other than your two highest oracle spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a8d4b924-524b-4b6b-9f73-d9e04fd46f7c"), Feats.Instances.BasicOracleSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("248ebe83-7ab5-4b0b-a44d-633ae4a5246f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
