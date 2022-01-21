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
    public class Mahathallah : Template
    {
        public static readonly Guid ID = Guid.Parse("d7f77479-eb0a-4997-b677-82c997768341");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.QueensOfTheNight.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Mahathallah",
                Edicts = "Become an arbiter of reality, reject conventional wisdom as falsehood, capitalize on the ignorance of others.",
                Anathema = "Become too invested in mortal affairs.",
                Title = "Dowager of Illusions",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6135f6e4-13ba-488f-b689-f6469903fdf4"), Type = TextBlockType.Text, Text = "While the other Queens of the Night are all fallen celestials, Mahathallah was once among the most powerful of the monitors: a psychopomp usher in service of Pharasma. Granted a glimpse of the end of her own existence, Mahathallah fled to the pits of Hell, finding some form of solace in Asmodeus's counsel. Now the Dowager of Illusions, Mahathallah deals in death, fate, and vanity, pulling back the veils of lies that obscure the profound facts of existence. She teaches her followers to seek the truths underlying each falsehood, fomenting arrogance and callousness in them. She also serves as a distant, deliberate advisor to the other Queens of the Night." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("37655959-a3d7-4ee1-8f61-0a75385d37a9"), Spells.Instances.IllusoryDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse("3709943d-5786-4e66-b1b7-0f41cfdb224b"), Spells.Instances.Misdirection.ID);
            builder.GainSpecificSpell(Guid.Parse("cad7419d-8d7a-40b4-adb4-1991ddc5b986"), Spells.Instances.IllusoryScene.ID);
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
            
            yield return Items.RangedWeapons.Instances.Bola.ID;
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
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Truth.ID;
            yield return Domains.Instances.Undeath.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("978383b8-31d0-4141-ae39-2ffdda81d495"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
