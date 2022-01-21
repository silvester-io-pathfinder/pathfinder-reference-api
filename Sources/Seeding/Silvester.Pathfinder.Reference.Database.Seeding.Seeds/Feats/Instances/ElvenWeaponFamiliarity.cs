using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElvenWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("b1880998-7f46-495e-ba09-a7f759fd7509");

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
            yield return new TextBlock { Id = Guid.Parse("ad5db30f-d829-4660-9f88-32995dfab70f"), Type = TextBlockType.Text, Text = $"You favor bows and other elegant weapons. You are trained with longbows, composite longbows, longswords, rapiers, shortbows, and composite shortbows." };
            yield return new TextBlock { Id = Guid.Parse("71174c8d-d902-4275-a1b5-50ae2ff0a104"), Type = TextBlockType.Text, Text = $"In addition, you gain access to all uncommon elf weapons. For the purpose of determining your proficiency, martial elf weapons are simple weapons and advanced elf weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee5fbf76-18e0-40da-9b7a-9ade0a72f97c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
