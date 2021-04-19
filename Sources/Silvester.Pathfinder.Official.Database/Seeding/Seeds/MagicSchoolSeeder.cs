using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class MagicSchoolSeeder : IEntitySeed<MagicSchool>
    {
        public IEnumerable<MagicSchool> GetSeedEntities()
        {
            yield return new MagicSchool { Id = Guid.Parse("76c4e166-abdb-471f-8fde-4c08a765ce2b"), Name = "Abjuration", Abbreviation = "ABJ", Description = "Abjurations protect and ward. They create barriers that keep out attacks effects, or even certain types of creatures. They also create effects that harm trespassers or banish interlopers." };
            yield return new MagicSchool { Id = Guid.Parse("1c401dd4-21d6-477d-9ca1-1a6a9d1a8a0d"), Name = "Conjuration", Abbreviation = "CON", Description = "Conjuration spells transport creatures via teleportation, create an object, bring a creature or object from somewhere else (typically from plane) to follow your commands Conjuration spells often have the teleportation trait, and creatures summoned by conjuration spells have the summoned trait." };
            yield return new MagicSchool { Id = Guid.Parse("cbb0592d-be14-4588-a0af-1f16aad3a4a6"), Name = "Divination", Abbreviation = "DIV", Description = "Divinations allow you to learn the secrets of the present, past, and future.They bestow good fortune, grant you the ability to perceive remote locations, and reveal secret knowledge. Divinations often have the detection trait if they find something, the prediction trait if they grant you insight about what might happen in the future, the revelation trait if they show things as they truly are, or the scrying trait if they let you perceive another location." };
            yield return new MagicSchool { Id = Guid.Parse("652580a1-b993-4326-9baa-460b5f6c9ba0"), Name = "Enchantment", Abbreviation = "ENC", Description = "Enchantments affect the minds and emotions of other creatures—sometimes to influence and control them, and other times to bolster them to greater heights of courage. Enchantment spells almost always have the mental trait, and many have the emotion trait or the fear trait." };
            yield return new MagicSchool { Id = Guid.Parse("438b96b3-ea22-4131-b938-ce7073c933b4"), Name = "Evocation", Abbreviation = "EVO", Description = "Evocations capture magical energy and then shape it to harm your foes or protect your allies. Evocation spells often have a trait that comes from the type of damage they deal, such as acid, cold, fire, force, or sonic." };
            yield return new MagicSchool { Id = Guid.Parse("dd5fe60b-e821-4f80-86cb-ed5a9791d1e7"), Name = "Illusion", Abbreviation = "ILL", Description = "Illusions create the semblance of something real, the eyes, ears, and other senses.Depending on how the illusion is perceived, it might have the auditory or traits, and some also have the mental trait." };
            yield return new MagicSchool { Id = Guid.Parse("fe316215-5436-422b-bd3f-c499d05b5b99"), Name = "Necromancy", Abbreviation = "NEC", Description = "Necromancy spells harness the power of life and death. They can sap life essence or sustain creatures with life-saving healing. Necromancy spells often have the curse, death, healing, negative, or positive traits." };
            yield return new MagicSchool { Id = Guid.Parse("ab0fac81-a9ed-410e-9886-99923111080a"), Name = "Transmutation", Abbreviation ="TRA", Description = "Transmutation spells make alterations to or transform the physical form of a creature or object.The morph and polymorph traits appear primarily in transmutation spells." };
        }
    }
}
