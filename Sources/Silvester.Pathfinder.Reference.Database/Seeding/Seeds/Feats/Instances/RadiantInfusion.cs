using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RadiantInfusion : Template
    {
        public static readonly Guid ID = Guid.Parse("b36773c6-aae3-40f6-b75f-566a44f69b3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Infusion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc5a3735-c7c6-4746-860c-92c7d5b44fbe"), Type = TextBlockType.Text, Text = "You pour invigorating positive energy into a living ally. If the next action you use is to cast (spell: heal) to restore Hit Points to a single living creature, the target deals an additional 1d6 positive damage with its melee weapons and unarmed attacks until the end of its next turn. If the (spell: heal) spell is at least 5th level, this damage increases to 2d6, or 3d6 if the spell is at least 8th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3e3e0c9e-c1a4-4881-988e-9f743512aae2"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("04f31693-2afa-4017-8559-34cb6b8fb36a"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("a4fe36b9-47c6-4ef3-849f-94cda17f86a2"), Alignments.Instances.NeutralGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("0048ac3f-bc52-4f31-a0fa-100bd431def6"), Alignments.Instances.ChaoticGood.ID);
            });
            builder.HaveSpecificDivineFont(Guid.Parse("8c575811-52f9-49ce-87b1-ef66fd364b4d"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc13df44-1e2d-4148-a645-68b9982138d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
