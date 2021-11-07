using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodComponentSubstitution : Template
    {
        public static readonly Guid ID = Guid.Parse("b6653409-7b22-4373-89c4-f0af4025c890");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blood Component Substitution",
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
            yield return new TextBlock { Id = Guid.Parse("f122d039-1ec4-4162-8350-7b063b89337a"), Type = TextBlockType.Text, Text = "You can bypass the need for incantations and gestures by drawing energy directly from your blood, causing you to visibly glow the color of your blood and crackle with magical energy. When you (activity: Cast a Spell), you can replace all verbal, material, or somatic spellcasting components with a blood component. To use a blood component, you lose Hit Points equal to twice the spell’s level as the energy in your blood is depleted, and you can’t decrease the Hit Points lost in any way. As usual for altering components, this has no effect on the number of actions required to (activity: Cast a Spell), and your (activity: Cast a Spell) activity gains the (trait: concentrate) trait but not the (trait: manipulate) trait. You can’t use blood components to replace any required part of a spell’s cost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6d0139e-2652-4714-b41a-636a65493bb5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
