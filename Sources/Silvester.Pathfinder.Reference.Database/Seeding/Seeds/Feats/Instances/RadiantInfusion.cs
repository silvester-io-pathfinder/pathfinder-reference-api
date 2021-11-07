using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RadiantInfusion : Template
    {
        public static readonly Guid ID = Guid.Parse("b8997435-f0c6-4bb6-8828-b94100798cf6");

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
            yield return new TextBlock { Id = Guid.Parse("66a15cce-82cc-44db-931e-b2d6c18066c1"), Type = TextBlockType.Text, Text = "You pour invigorating positive energy into a living ally. If the next action you use is to cast (spell: heal) to restore Hit Points to a single living creature, the target deals an additional 1d6 positive damage with its melee weapons and unarmed attacks until the end of its next turn. If the (spell: heal) spell is at least 5th level, this damage increases to 2d6, or 3d6 if the spell is at least 8th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("bc0f3bd3-1111-4aa8-b21e-5f4586727686"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("ab6e48b9-3a8e-4c6f-8692-a7f2d6bdc9d3"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("da1047ba-6cc7-460c-8e31-ff00ab81fd07"), Alignments.Instances.NeutralGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("6e430707-0103-4cab-82e7-d255918fd9b3"), Alignments.Instances.ChaoticGood.ID);
            });
            builder.HaveSpecificDivineFont(Guid.Parse("7219fba6-68f1-481f-b415-48287f7f3c3a"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2f1079d-5338-43a7-9c52-7d905c1dc882"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
