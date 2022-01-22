using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeartOfTheKaiju : Template
    {
        public static readonly Guid ID = Guid.Parse("4e00f6b1-7d12-43b3-86bd-bee317228b68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heart of the Kaiju",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9b66fa9-23e7-4906-8f1a-3011a9637188"), Type = TextBlockType.Text, Text = $"Witnessing the might of the kaiju King Mogaru, Alru, and Toraloa up close awoke a new ferocity within you. When you transform using {ToMarkdownLink<Models.Entities.Feat>("Monstrosity Shape", Feats.Instances.MonstrosityShape.ID)}, you can take on a kaiju form. When you take this feat, choose acid, cold, electricity, fire, or sonic damage; this is the damage your breath weapon deals. You can't change this later. The battle form is Gargantuan size with the following specific abilities; the damage values already include the extra die from being a 9th-level spell." };
            yield return new TextBlock { Id = Guid.Parse("7c0472f2-e6f7-4e23-8077-930817c63fa2"), Type = TextBlockType.Enumeration, Text = $" : Kaiju **Speed** 40 feet; physical resistance 5; **Melee** ONE-ACTION jaws ({ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)} 20 feet), **Damage** 3d12+20 piercing; **Melee** ONE-ACTION claws ({ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)} 20 feet), **Damage** 3d8+20 slashing; **Breath Weapon**TWO-ACTIONS ({ToMarkdownLink<Models.Entities.Trait>("evocation", Traits.Instances.Evocation.ID)}, {ToMarkdownLink<Models.Entities.Trait>("primal", Traits.Instances.Primal.ID)}) Each creature in a 60-foot cone takes 15d6 damage (of your chosen damage type), with a basic Reflex save against your spell DC. Once activated, your breath weapon can't be used again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("67dbcaaf-9609-41c7-9b48-543dffdddf78"), Feats.Instances.MonstrosityShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23fe1d5b-4431-4c84-855e-f0e7a20f20dd"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
