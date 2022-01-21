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
    public class Droskar : Template
    {
        public static readonly Guid ID = Guid.Parse("3c7f3086-162f-4df3-975a-25dc3cdda633");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DwarvenGods.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Droskar",
                Edicts = "Achieve goals at any cost, continually improve your abilities, establish dominance, work ceaselessly.",
                Anathema = "Fail to work toward goals or grow in skill, relax excessively or give into sloth.",
                Title = "The Dark Smith",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("ead515cc-c446-4b02-9235-2a99e43c6414"), Type = TextBlockType.Text, Text = ",Pathfinder #148: Fires of the Haunted City pg. 64" };
            yield return new TextBlock { Id = Guid.Parse("62445d4c-b320-4969-a7c6-33c9b7037a9b"), Type = TextBlockType.Text, Text = "Cast out and cursed byTorag, the Dark Smith works constantly to prove his significance, cheating and enslaving others to further his goal" };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c3e690f9-9ea6-483a-80f9-fe6a67c27e06"), Spells.Instances.AntHaul.ID);
            builder.GainSpecificSpell(Guid.Parse("22eb9926-7c53-4846-8c69-61b9dc7307f5"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("0fd43f22-126f-40ae-9ba0-318adad56215"), Spells.Instances.Dominate.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.LightHammer.ID;
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
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("76f588b2-f3aa-4de2-b08e-effd4dc4d796"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 127
            };
        }
    }
}
