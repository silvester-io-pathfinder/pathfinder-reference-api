using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiverseArmorExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("bbf9bc2e-1516-4af2-b524-de49271a72a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diverse Armor Expert",
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
            yield return new TextBlock { Id = Guid.Parse("9603bfed-05fb-47e6-9ef0-d0098c5323c0"), Type = TextBlockType.Text, Text = "Your proficiency ranks for light armor, medium armor, heavy armor, and unarmored defense increase to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("37ec1734-70e7-4d26-a66d-b272a465ba26"), Feats.Instances.ChampionDedication.ID);
            builder.HaveAnyArmorCategorySpecificProficiency(Guid.Parse("99d758a8-afcb-454f-92cb-9ff34b4a3cb6"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6eca690e-ebc4-4262-8db0-51a66b298273"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
