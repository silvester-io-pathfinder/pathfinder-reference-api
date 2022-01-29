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
    public class StealEssence : Template
    {
        public static readonly Guid ID = Guid.Parse("e2a6ddbe-3c4c-49c6-933c-23d91d0995bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steal Essence",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a85c6259-d6f6-4efb-a463-418825cc3714"), Type = TextBlockType.Text, Text = $"Being in the presence of the aeon orbs as they deteriorated has taught you how to siphon energy, and you do so with the required magic item. The DC to steal the properties of a magic item is equal to the DC for the item's level or the normal DC to {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} the item, whichever is higher. The targeted item then becomes temporarily immune for 24 hours. If the object was on a creature, that creature is also temporarily immune (which prevents you from attempting to Steal the Essence of another object on it)." };
            yield return new TextBlock { Id = Guid.Parse("0bc355c1-63f6-43f7-9cc2-5c662f5aed11"), Type = TextBlockType.Text, Text = $"If you successfully steal the properties of an item, it loses its magical properties for 24 hours and you can move those properties to a non-magical object of the same general kind (such as moving a hat's properties to another piece of headgear or moving a weapon's properties to another weapon) for the same length of time. If the moved properties are counteracted, they return immediately to the original item. You automatically fail to Steal the Essence of an artifact, cursed item, or similar item." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d75360b4-5c70-45fc-9409-6ef3f31c63bf"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("2f6e6558-8ab4-4879-a7b6-247e5c6df9cd"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Thievery.ID);
                or.AddOr(Guid.Parse("ca12e238-d742-458a-a2e1-a92944e79ade"), or => 
                {
                    or.HaveSpecificSkillProficiency(Guid.Parse("3a7de318-9f50-45de-a1df-e6458537545c"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("91f97c1a-a0a4-4789-9fc7-95c35133e542"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("56fc8eb8-87c8-4be2-859c-820486211ccd"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("7b471ccc-29ae-40c7-b18b-66440cfee47a"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
                });
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b63000fc-ab13-4d20-952b-a5b4546d9e99"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
