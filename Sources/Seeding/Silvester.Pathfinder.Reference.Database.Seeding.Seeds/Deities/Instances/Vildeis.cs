using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Vildeis : Template
    {
        public static readonly Guid ID = Guid.Parse("228c2eac-c0b5-4dde-979d-b83d116a7714");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Vildeis",
                Edicts = "Sacrifice yourself in pursuit of good, champion noble causes, scar your body.",
                Anathema = "Joke or laugh about injustice, sacrifice others in your place, indulge in luxury.",
                Title = "The Cardinal Martyr",
                AreasOfConcern = "Devotion, sacrifice, and scars.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("bd43a8c9-7d08-460f-8c26-5053e7366cb1"), Type = TextBlockType.Text, Text = "The Cardinal Martyr presides over devotion, sacrifice, and scars. Vildeis is driven entirely by her abhorrence for evil. Evil should not and must not be allowed to exist. It should be fought without pause and without rest until it is completely and utterly destroyed. Not only does the fight never end, but every sacrifice that needs to be made to end evil must be made, and is worth making. There are no material rewards to be had for destroying evil—its destruction is all the reward necessary, and that reward can be enjoyed only once there is no more evil. Scars are the marks the fight leaves behind, the memory of all the sacrifices made. Vildeis expects total commitment from her followers, who leave everything behind and dedicate their lives to destroying all that is vile." };
            yield return new TextBlock { Id = Guid.Parse("aeb93a9f-8d27-4453-9c57-c08a93543131"), Type = TextBlockType.Text, Text = "The Cardinal Martyr appears as a human woman covered in scars, each forming a rune depicting a sacrifice she has made. Her eyes are covered in a red cloth so that she cannot see the horrors of evil upon the world. Vildeis flies on gigantic, blood-colored wings, and the whispered screams of all the planes' martyrs can be heard in her presence. Followers of Vildeis include martyrs, paladins, and zealots." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("8976ee2a-d010-4808-bc40-a169576bd36e"), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse("eb551db3-6724-4cd7-ae4d-fa32c1c37d04"), Spells.Instances.SloughSkin.ID);
            builder.GainSpecificSpell(Guid.Parse("547c9a25-feb5-4b28-9469-1991c716b4ed"), Spells.Instances.SynapticPulse.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Dagger.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Pain.ID;
            yield return Domains.Instances.Sorrow.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("b75bc631-d9d9-41be-a309-2d565b143c8d"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
