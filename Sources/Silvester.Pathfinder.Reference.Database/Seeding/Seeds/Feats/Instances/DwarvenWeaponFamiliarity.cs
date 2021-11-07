using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DwarvenWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("61796d3a-2be8-45fe-a67f-878c419f1dea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dwarven Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51d31f3e-cb93-4ed0-9988-fbcf40d773ca"), Type = TextBlockType.Text, Text = "Your kin have instilled in you an affinity for hard-hitting weapons, and you prefer these to more elegant arms. You are trained with the battle axe, pick, and warhammer." };
            yield return new TextBlock { Id = Guid.Parse("9ad94167-ae2b-4731-b9be-b74793314396"), Type = TextBlockType.Text, Text = "You also gain access to all uncommon dwarf weapons. For the purpose of determining your proficiency, martial dwarf weapons are simple weapons and advanced dwarf weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("368c43d2-e94a-4725-9d9d-7516313a2026"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
