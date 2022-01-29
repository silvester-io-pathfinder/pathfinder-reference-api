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
    public class ExpansiveSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e3510f68-279f-4a0c-8737-65b8fd5fa1ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expansive Spellstrike",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b2afcd1d-ea09-4eb3-82ac-342645fca67a"), Type = TextBlockType.Text, Text = $"You've adapted a wider array of spells to work with your attacks. Rather than needing to use a spell that has a spell attack roll for a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}, you can use a harmful spell that can target a creature or that has an area of a burst, cone, or line (abiding by any other restrictions of {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}). When you {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that doesn't have a spell attack roll as part of a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}, it works in the following ways." };
            yield return new TextBlock { Id = Guid.Parse("f68886db-b315-4e97-a0cb-57e9179916f0"), Type = TextBlockType.Enumeration, Text = $" : If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} critically fails, the spell is lost with no effect." };
            yield return new TextBlock { Id = Guid.Parse("7c19a6e4-3465-4c67-845b-7e0e7ae271e2"), Type = TextBlockType.Enumeration, Text = $" : Creatures use their normal defenses against the spell, such as saving throws." };
            yield return new TextBlock { Id = Guid.Parse("ce54d376-4a1d-4fda-ae15-e8faf18867fe"), Type = TextBlockType.Enumeration, Text = $" : If the spell lets you select a number of targets, it instead targets only the creature you attacked with your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("88c5a276-ceac-4904-8ab4-adc47cbebf21"), Type = TextBlockType.Enumeration, Text = $" : If the spell has an area, the target must be in that area. A burst is centered on a corner of the target's square, or the square corner closest to the center of the target, if the target is Large or larger; you choose the corner if more than one is eligible. A cone or line emits from you and must include the target; if you're not adjacent to the target (using a reach weapon or starlit span, for example), choose any square adjacent to the target as the source. The spell affects all creatures in the area as normal, but the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} still targets only one creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("70044148-21bd-40e3-8ee9-743a0c4681c2"), Feats.Instances.Spellstrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53c4ee8f-281c-4cf5-8767-9e26f8529fef"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
