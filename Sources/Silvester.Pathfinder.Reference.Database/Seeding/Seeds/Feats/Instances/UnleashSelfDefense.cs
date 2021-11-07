using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashSelfDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("4c031ef0-dc02-464b-8a00-01dd255566a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Self-Defense",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f36fa0f-cd57-4eb0-bac7-8227b455125f"), Type = TextBlockType.Text, Text = "The conflict-averse aspects of your personality float calmly to the surface, causing your mind to subconsciously deflect incoming attacks, though this comes at the cost of reduced fatal intent behind your spells." };
            yield return new TextBlock { Id = Guid.Parse("2ab549d7-008e-4d86-817a-d373e3e83b4d"), Type = TextBlockType.Text, Text = "~ Benefit: While this psyche is Unleashed, you gain a +1 status bonus to your AC and to one saving throw of your choice, decided when you Unleash your psyche. All of your spells that don’t have the (trait: death) trait gain the (trait: nonlethal) trait." };
            yield return new TextBlock { Id = Guid.Parse("e559ad58-dc8f-4d84-aa09-f6241e18ef9a"), Type = TextBlockType.Text, Text = "~ Drawback: The pacifist influence on your mind makes it difficult for your spells to strike a killing blow. You take a penalty to spell damage rolls equal to the level of the spell, and you take a –1 penalty to spell attack rolls and DC of any spell that deals damage or otherwise affects the target’s health or Hit Points (including those that apply the drained condition, disease or poison the target, or kill the target)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a2e169e-1b49-4d63-9399-fb9c784415b9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
