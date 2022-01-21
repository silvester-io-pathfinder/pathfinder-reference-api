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
    public class Eiseth : Template
    {
        public static readonly Guid ID = Guid.Parse("1d7255ae-41df-43a7-9c3d-6aea39768a61");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.QueensOfTheNight.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Eiseth",
                Edicts = "Avenge all insults, claim what you desire and deserve, humiliate your foes in ironic fashion.",
                Anathema = "Allow a slight to go unanswered, show humility or fear.",
                Title = "The Erinyes Queen",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("bfea1307-41d3-4e59-b9f3-e66204b97f8e"), Type = TextBlockType.Text, Text = "Hell's Valkyrie rules a domain spanning part of Dispater's realm, commanding her legions of erinyes and executioner devil soldiers as she sees fit. Eiseth operates outside Dispater's rule, and she has forged powerful alliances with those in Hell and beyond, having long ago rejected limitations placed upon her by others. Foremost among the Queens of the Night, she embodies battle, revenge, and wrath, and her ambitions are as lofty as her aerie of Widow's Cry, where she forges souls of the damned into unequaled infernal legions answering to her alone." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("1421b0b1-7ef6-45b8-9764-d4187c4cb003"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("89951341-9c8e-4ac2-8ec1-b18d02d2ca01"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("8cb770c2-6457-467f-b3bb-7a3b5eca3905"), Spells.Instances.DimensionDoor.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return Items.RangedWeapons.Instances.Longbow.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f895feb-0dd6-4355-8789-bd5204627b9f"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}