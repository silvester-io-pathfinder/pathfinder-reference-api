using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonKaiju : Template
    {
        public static readonly Guid ID = Guid.Parse("f5ced913-862b-478f-a46a-0b59fc45653e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Kaiju",
                Level = 10,
                Range = "500 feet.",
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5475573-8cdb-4b97-b355-8ebd65d17866"), Type = TextBlockType.Text, Text = "You briefly conjure a kaiju, a massive, rampaging monster with a unique name and legendary reputation. It rises from its secluded lair to annihilate your foes. The summoned kaiju occupies the space of a Gargantuan creature. When you Cast this Spell, choose one of the kaiju below to summon." };
            yield return new TextBlock { Id = Guid.Parse("1d40f56d-0835-43d5-908d-6786665d779e"), Type = TextBlockType.Enumeration, Text = "Agmazar the Star Titan Speed 100 feet, climb 50 feet; Arrive (necromancy, negative) Channel Void Each foe in a 100-foot emanation takes 16d8 negative energy damage with a basic Fortitude save; Depart (transmutation) Gravitic Repulsion Each foe in a 50-foot emanation is pushed 100 feet away unless it succeeds at a Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("ed6fd613-baf3-4a14-8e36-0c2f32294cd2"), Type = TextBlockType.Enumeration, Text = "Agyra, the Forever Storm Speed 80 feet, fly 200 feet; Arrive (electricity, evocation) Breath of a Thousand Storms Agyra shoots two 1,200-foot lines of electricity, one from each of her heads. The lines can't overlap. Each creature along one of the lines takes 6d12 electricity damage with a basic Reflex save. On a failure, the creature is also slowed 1 for 1 round (or for 1 minute on a critical failure); Depart (evocation, sonic) Thunderous Blast Each creature within a 100-foot emanation takes 6d10 sonic damage with a basic Reflex save, and is also knocked prone on a failed save." };
            yield return new TextBlock { Id = Guid.Parse("86148d8f-2106-4ae4-b8a9-d5b200dad65d"), Type = TextBlockType.Enumeration, Text = "Bezravnis, the Inferno Below Speed 100 feet, burrow 100 feet; Arrive (earth, evocation) Burrow from the Earth's Heart Bezravnis explodes from the ground where it was summoned, causing all creatures in a 50-foot emanation to take 8d12 bludgeoning damage with a basic Reflex save. This potentially collapses structures with the collapse effect of the earthquake spell, except there is no chance of falling into a fissure; Depart Web Hurricane Bezravnis departs with a hurricane of webbing. All creatures within a 50-foot emanation must succeed at a Reflex save or take a -20-foot circumstance penalty to its Speeds until it Escapes (or is immobilized until it escapes on a critical failure). The Escape DC is your spell DC." };
            yield return new TextBlock { Id = Guid.Parse("9113c04b-1bc5-4493-808f-e80dd70ea823"), Type = TextBlockType.Enumeration, Text = "Mogaru, the Final King Speed 100 feet, swim 100 feet; Arrive (auditory, enchantment, mental) Trance of the King's Melody Mogaru manifests with a burst of the song that summoned him, requiring all foes within 60 feet who can hear him to attempt a Will save, leaving them stunned 3 on a failure; Depart (evocation, fire) Volcanic Breath Mogaru unleashes his scorching breath in a 120-foot cone. Each creature in the area takes 10d6 fire damage with a basic Reflex save. On a failure, it also takes 4d6 persistent fire damage." };
            yield return new TextBlock { Id = Guid.Parse("ee568336-37ba-45f8-8b33-0cae4b1072cc"), Type = TextBlockType.Enumeration, Text = "Vorgozen, the Shapeless Feeder Speed 50 feet, climb 50 feet, swim 100 feet; Arrive (necromancy) Pollute Magic Vorgozen's foul presence pollutes magic around her. Each of your enemies within a 60-foot emanation that are under the effects of a spell must attempt a Fortitude save. On a failure, the creature is sickened 2. Any of your enemies that Casts a Spell within 60 feet of Vorgozen must attempt a Fortitude save with the same effects unless it's already sickened; Depart (acid, evocation) Beam of Purest Vitriol Each creature in a 1,200-foot line takes 10d6 acid damage and 10d6 bludgeoning damage with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("8d191454-df0b-4286-b920-5f23df983a78"), Type = TextBlockType.Enumeration, Text = "Yarthoon, the Moon Grub Speed 60 feet, burrow 100 feet, fly 100 feet, swim 100 feet; Arrive (cold, evocation) Algid Beam Barrage Yarthoon fires countless beams, targeting each of your enemies within 200 feet of it. The beams deal 10d6 cold damage with a basic Reflex save; Depart (cold, conjuration, water) Frostbite Mist Chilling mist surges out in a 100-foot burst centered on Yarthoon and remains for 1 minute. This mist has the effects of obscuring mist, plus any creature within the area at the end of its turn take 5d6 cold damage with a basic Fortitude save." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0fef8739-e4d1-4f67-a0cc-8d8cb9410aaf"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("24c8314f-2fb6-4336-bad5-8bbc7d42a17e"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("a00201dc-f4c9-49c3-8c8f-ddd610971ea2"), Traits.Instances.Incarnate.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01cd71e9-0b61-4c9a-a35b-117b9ebff43c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 133
            };
        }
    }
}
