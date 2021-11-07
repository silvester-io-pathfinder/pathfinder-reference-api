using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellTinker : Template
    {
        public static readonly Guid ID = Guid.Parse("359eb04f-6de4-4b6f-9817-6dffacb0944f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Tinker",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82cfbeaa-27b0-44a7-93ed-f1f925561cbc"), Type = TextBlockType.Text, Text = "You’ve learned to alter choices you make when casting spells on yourself. After casting a spell on only yourself that offers several choices of effect (such as (Spell: resist energy), (Spell: spell immunity), or a polymorph spell that offers several potential forms), you can alter the choice you made when (activity: Casting the Spell | Cast a Spell) (for instance, choosing a different type of damage for (Spell: resist energy)). However, your tinkering weakens the spell’s integrity, reducing its remaining duration by half." };
            yield return new TextBlock { Id = Guid.Parse("8d5244da-a305-4736-92d0-168573f1adbd"), Type = TextBlockType.Text, Text = "You can’t use this feat if the benefits of the spell have already been used up or if the effects of the first choice would persist in any way after switching (for instance, if one of the choices was to create a consumable item you already used, or to heal you), or if the feat would create an effect more powerful than that offered by the base spell. The GM is the final arbiter of what Spell Tinker can be applied to." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("861c0d64-3e40-42ba-95f7-da2e87a27f25"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
