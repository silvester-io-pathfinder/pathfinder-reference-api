using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ViciousDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("84188d5b-2da7-422b-b990-60a578a4da3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vicious Debilitations",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84313330-a8dc-488a-b90e-b092ec0e5666"), Type = TextBlockType.Text, Text = "The debilitations you dish out seriously impair your foes. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("79ad23d1-d787-4920-a35d-d7fa6a7194e6"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target gains weakness 5 to your choice of bludgeoning, piercing, or slashing damage." };
            yield return new TextBlock { Id = Guid.Parse("dd75a6fa-ca18-4a11-b488-ea91f3f98d76"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target becomes clumsy 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("2b3b3868-c5bd-4849-bcc6-dd4a9ef931cd"), Rackets.Instances.Ruffian.ID);
            builder.HaveSpecificFeat(Guid.Parse("57bdc98d-0098-40b4-be40-3db8e5d3bd97"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec55ae7d-edad-43b7-9562-9bcecb86eaff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
