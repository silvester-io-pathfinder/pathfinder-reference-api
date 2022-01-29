using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellTinker : Template
    {
        public static readonly Guid ID = Guid.Parse("a6d01321-b5a1-43f8-b61c-f7ec3653a91c");

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
            yield return new TextBlock { Id = Guid.Parse("4fa3d644-1e44-4397-86d1-2b5adbfa9a84"), Type = TextBlockType.Text, Text = $"You've learned to alter choices you make when casting spells on yourself. After casting a spell on only yourself that offers several choices of effect (such as {ToMarkdownLink<Models.Entities.Spell>("resist energy", Spells.Instances.ResistEnergy.ID)}, {ToMarkdownLink<Models.Entities.Spell>("spell immunity", Spells.Instances.SpellImmunity.ID)}, or a polymorph spell that offers several potential forms), you can alter the choice you made when {ToMarkdownLink<Models.Entities.Rule>("Casting the Spell", Rules.Instances.CastASpell.ID)} (for instance, choosing a different type of damage for {ToMarkdownLink<Models.Entities.Spell>("resist energy", Spells.Instances.ResistEnergy.ID)}). However, your tinkering weakens the spell's integrity, reducing its remaining duration by half." };
            yield return new TextBlock { Id = Guid.Parse("35b70ba5-cb8c-4c97-9d9c-9f96cf0a7d2f"), Type = TextBlockType.Text, Text = $"You can't use this feat if the benefits of the spell have already been used up or if the effects of the first choice would persist in any way after switching (for instance, if one of the choices was to create a consumable item you already used, or to heal you), or if the feat would create an effect more powerful than that offered by the base spell. The GM is the final arbiter of what Spell Tinker can be applied to." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ae9cd092-d01b-4176-8f6b-a42e9a63133b"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("33547602-0627-42cd-ac1e-e6e892d25428"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("836b02ea-0d45-453d-ae96-3c607d3e646d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
