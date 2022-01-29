using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StormRetribution : Template
    {
        public static readonly Guid ID = Guid.Parse("1815d608-5d03-483b-abf1-e6eec1e7c14d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Storm Retribution",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent adjacent to you critically hits you with a melee weapon or melee unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91e3bedd-dd4d-4bd0-a1ea-9f20cf9166f5"), Type = TextBlockType.Text, Text = $"You lash out, directing a burst of storming fury toward a creature that has harmed you. You cast {ToMarkdownLink<Models.Entities.Spell>("tempest surge", Spells.Instances.TempestSurge.ID)} on the triggering opponent and push that creature, moving it 5 feet away from you if it fails its Reflex save, or 10 feet if it critically fails. This movement is forced movement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("4689fac9-2f21-475c-818a-1db64d579b36"), DruidicOrders.Instances.Storm.ID);
            builder.HaveSpecificSpell(Guid.Parse("0d187030-4cc1-4204-98fa-82a922b8e743"), Spells.Instances.TempestSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75e461c2-0154-423d-aeb1-24facf85adbb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
