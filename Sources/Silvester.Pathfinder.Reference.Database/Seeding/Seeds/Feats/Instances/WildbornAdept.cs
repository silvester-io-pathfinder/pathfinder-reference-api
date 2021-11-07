using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildbornAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("c4e9d794-6c24-4522-b9e4-3803a3062886");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wildborn Adept",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("caae760d-783a-4a5d-bd0b-c0d9a0ce6016"), Type = TextBlockType.Text, Text = "The whispers of the jungle grant you more diverse access to simple primal magic. You can cast (spell: dancing lights), (spell: disrupt undead), and (spell: tanglefoot) as innate primal spells at will. If you chose one of those spells with (feat: Wildborn Magic), you can select a new spell for (feat: Wildborn Magic)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("df73f8b0-d5ae-4717-92b9-f8eff8cbfaa9"), Feats.Instances.WildbornMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6761780-4b3d-4ccf-bdf9-ea504a996d54"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
