using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalSummons : Template
    {
        public static readonly Guid ID = Guid.Parse("a69bddd7-d737-4d60-9af2-ad64ff1c048c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Summons",
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
            yield return new TextBlock { Id = Guid.Parse("44a366ed-f14b-43dc-bf6c-8cae01e2cbbb"), Type = TextBlockType.Text, Text = "Whenever you summon an ally, you can empower it with the elemental power of air, earth, fire, or water. You gain the (Spell: primal summons) order spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("09c790c9-ff72-4b8f-b302-73e298a9696e"), Feats.Instances.CallOfTheWild.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4648280-b62e-490b-8b5a-5f66b092fd19"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
