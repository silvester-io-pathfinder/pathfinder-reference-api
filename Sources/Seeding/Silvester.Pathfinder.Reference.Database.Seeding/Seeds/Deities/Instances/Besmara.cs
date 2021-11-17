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
    public class Besmara : Template
    {
        public static readonly Guid ID = Guid.Parse("f819aa33-b602-44ee-8a41-02720e0224a3");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Besmara",
                Edicts = "Sail the seas, stay loyal to captain and crew, take what you want.",
                Anathema = "Betray shipmates, forsake piracy, settle on land.",
                Title = "The Pirate Queen",
                AreasOfConcern = "Piracy, sea monsters, and strife.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("ee5e4afb-0db4-4806-8600-18927bae0fe0"), Type = TextBlockType.Text, Text = "Once nothing more than a powerful spirit of water with the ability to manipulate sea monsters, Besmara grew slowly in power over the centuries from sacrifices made by seafaring people. After defeating and consuming rival spirits of battle, gold, and wood, she became a minor god of piracy, strife, and sea monsters." };
            yield return new TextBlock { Id = Guid.Parse("ade039a1-fb95-4b0a-8797-11556d324d26"), Type = TextBlockType.Text, Text = "Besmara, the Pirate Queen, cuts a brash and bold figure, as she often is depicted wearing buccaneer apparel consisting of loose-fitting, eye-catching clothing and black boots, and her hair is wind-tossed on even the calmest day. She and her followers adhere to a simple code of greed: take what you desire, no matter who it might belong to. Despite this, Besmara and her worshippers are generally loyal to one another, knowing that while on the waves raiding ships for treasure, a pirate crew can survive only if its members trust one another." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("36f150a0-6a9f-4fa4-b4e8-59ccaa4c4136"), Spells.Instances.HydraulicPush.ID);
            builder.GainSpecificSpell(Guid.Parse("4c58536a-1b29-4e05-85fe-c80993370ac6"), Spells.Instances.FeetToFins.ID);
            builder.GainSpecificSpell(Guid.Parse("27697cff-7b96-42df-b9c8-67607fe54f6a"), Spells.Instances.MarinersCurse.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Rapier.ID;
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
            
            return new DivineIntercession
            {
                Id = Guid.Parse("c0ab93cf-7dcf-4af6-ac1b-cfd4a13338ee"),
                Description = "Due to her fiery temperament, the Pirate Queen is quick to punish or reward her followers, and is equally fast at rescinding her favor or forgiving transgressions.",
                MinorBoon = "Besmara wants you to amuse her, placing both plunder and peril in your path. This intercession often takes the form of an unexpected treasure map, a message in a bottle, or some other sign leading you to a great reward, assuming you can handle the challenges along the way.",
                ModerateBoon = "You are at home on the seas and always ready to plunder an enemy vessel or defend your own. When aboard a boat, you gain a +2 status bonus to all initiative rolls, Acrobatics checks to Balance, and Athletics checks to Climb. In addition, you never get seasick.",
                MajorBoon = "You seem to be unaffected by storms. You ignore all effects and penalties caused by precipitation and winds, and you can see normally through fog, rain, and other weather conditions.",
                MinorCurse = "You feel some of the effects of scurvy, making your wounds flow more easily. The DC of the flat check for you to remove persistent bleed damage is 20 instead of 15 (or 15 instead of 10 if using extremely efficient methods to assist your recovery), and you don't recover from persistent bleed damage automatically when you reach full Hit Points.",
                ModerateCurse = "You get seasick, becoming sickened 2 whenever you can see the sea or are on a boat at sea. You can't reduce this condition until you can no longer see the sea or are off the boat, though you can manage to stomach enough food and water to survive on a voyage, with extreme discomfort.",
                MajorCurse = "You meet extreme financial ruin for daring to gravely offend the Pirate Queen. Besmara's agents steal all your booty and bring the spoils to Besmara's ship, Seawraith. If you want a chance to recover your lost wealth, you must parlay with the goddess and accept whatever dangerous terms she offers, usually requiring a heist she will find sufficiently amusing to watch whether you succeed or fail, and requiring you to trade your spoils from that quest for your previous belongings.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("a5abd205-f119-4689-ad28-ab09dc04d50f"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 4
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Water.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("05f6c8b9-dcb9-4487-8cdf-cd404f45f74c"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 55
            };
        }
    }
}
