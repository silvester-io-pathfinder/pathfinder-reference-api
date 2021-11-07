using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HobgoblinWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("4902e1d6-413a-465a-ae07-bbdef087b5ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hobgoblin Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("e1d7e4d8-c7d4-44e5-bfef-0fb2c1c4ccf6"), Type = TextBlockType.Text, Text = "You are trained with composite longbows, composite shortbows, glaives, longbows, longswords, and shortbows. In addition, you gain access to all uncommon hobgoblin weapons. For the purpose of determining your proficiency, martial hobgoblin weapons are simple weapons and advanced hobgoblin weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00515a47-3461-476a-b457-eea8797949e5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
