using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalSummons : Template
    {
        public static readonly Guid ID = Guid.Parse("53c3c5a1-bc2b-4fa6-bcd6-59b2803680eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Summons",
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
            yield return new TextBlock { Id = Guid.Parse("8d311797-12fe-4ac0-832a-9305decaf808"), Type = TextBlockType.Text, Text = "You can call the four elements to you. You can spend 10 minutes in concert with nature to replace one of the spells you’ve prepared in one of your druid spell slots with a (spell: summon elemental) spell of the same level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c181209-3894-446a-88dc-fecce9147ffc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
