using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElvenWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("e4558174-901f-49fa-9851-76dc3af2ff13");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elven Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("c06a9e8f-b412-4a4c-b39a-d477c54722b7"), Type = TextBlockType.Text, Text = "You favor bows and other elegant weapons. You are trained with longbows, composite longbows, longswords, rapiers, shortbows, and composite shortbows." };
            yield return new TextBlock { Id = Guid.Parse("77a499e7-be93-4703-aeb0-06c5a4d45dc0"), Type = TextBlockType.Text, Text = "In addition, you gain access to all uncommon elf weapons. For the purpose of determining your proficiency, martial elf weapons are simple weapons and advanced elf weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21d813ff-497c-45c9-9ccc-7e6281c519a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
