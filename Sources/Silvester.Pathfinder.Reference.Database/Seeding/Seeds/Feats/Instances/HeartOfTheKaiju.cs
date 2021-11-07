using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeartOfTheKaiju : Template
    {
        public static readonly Guid ID = Guid.Parse("9d83d5d3-6726-4961-8237-e37d42d45406");

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
            yield return new TextBlock { Id = Guid.Parse("099b9e68-f9d2-4647-885b-5c937865e74d"), Type = TextBlockType.Text, Text = "Witnessing the might of the kaiju King Mogaru, Alru, and Toraloa up close awoke a new ferocity within you. When you transform using (feat: Monstrosity Shape), you can take on a kaiju form. When you take this feat, choose acid, cold, electricity, fire, or sonic damage; this is the damage your breath weapon deals. You can&#39;t change this later. The battle form is Gargantuan size with the following specific abilities; the damage values already include the extra die from being a 9th-level spell." };
            yield return new TextBlock { Id = Guid.Parse("0de0148f-241a-41fd-9e9f-2718e848155c"), Type = TextBlockType.Enumeration, Text = " : Kaiju **Speed** 40 feet; physical resistance 5; **Melee** ONE-ACTION jaws ((trait: reach) 20 feet), **Damage** 3d12+20 piercing; **Melee** ONE-ACTION claws ((trait: agile), (trait: reach) 20 feet), **Damage** 3d8+20 slashing; **Breath Weapon**TWO-ACTIONS ((trait: evocation), (trait: primal)) Each creature in a 60-foot cone takes 15d6 damage (of your chosen damage type), with a basic Reflex save against your spell DC. Once activated, your breath weapon can&#39;t be used again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa866ed7-6196-4f4c-a314-e6a847042b30"), Feats.Instances.MonstrosityShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("200361a8-f3c4-4779-972d-2b3fd5f8f95b"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
