using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AttunementToStone : Template
    {
        public static readonly Guid ID = Guid.Parse("6a806345-62d8-4150-8484-7164940ecf70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Attunement to Stone",
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
            yield return new TextBlock { Id = Guid.Parse("ffe5fbf3-b51b-4437-b957-b8b8242a7fae"), Type = TextBlockType.Text, Text = "You become attuned to the stone around you. When in contact with a stone surface, you gain tremorsense (imprecise) 5 feet along that surface, and you can activate your ka stone to cast (spell: meld into stone)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a3c64031-4b1f-41e7-9385-b6dfd06f685e"), Feats.Instances.KaStoneRitual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f9753d8-113e-41d5-bb04-7d52ead7a4b7"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
