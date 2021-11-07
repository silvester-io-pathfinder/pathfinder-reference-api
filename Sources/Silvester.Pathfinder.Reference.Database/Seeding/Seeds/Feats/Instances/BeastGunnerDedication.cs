using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastGunnerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c3e87096-ac0e-4944-9873-c9a444afc551");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Gunner Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the beast gunner archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("67ee4ccc-16a4-4a95-9d66-5c25e74ab210"), Type = TextBlockType.Text, Text = "You’ve bonded to your beast gun and unlocked the first hints of its hidden potential. You treat all beast guns as martial firearms when determining your proficiency with them, even beast guns that are normally advanced weapons. You can change your bonded beast gun to another beast gun you own each day during your daily preparations, as long as you’ve previously performed a ritual hunt associated with the new beast gun." };
            yield return new TextBlock { Id = Guid.Parse("7dd0c350-a17c-448a-adbd-b0f4474f416c"), Type = TextBlockType.Text, Text = "The beast gun also acts as a conduit, drawing out and amplifying any latent or active magic power you have. You learn to cast spontaneous spells and gain the (activity: Cast a Spell) activity. You gain a spell repertoire with one cantrip of your choice, from either the arcane or primal spell list. You choose this cantrip from the common spells on your chosen spell list or from other spells you have access to on the list. This cantrip must require a spell attack roll. You’re trained in spell attack rolls and spell DCs for arcane or primal spells, whichever of the two traditions you chose. Your key spellcasting ability for these spells is Charisma." };
            yield return new TextBlock { Id = Guid.Parse("1bac026b-db84-4a11-b5dd-e360909aacc0"), Type = TextBlockType.Text, Text = "If you already cast arcane or primal spells from spell slots, you learn one additional cantrip from that tradition. If you’re a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you’re a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("a49d926e-59cf-43f1-b3a5-d38959d5d1ba"), Type = TextBlockType.Text, Text = "You also gain (feat: Spellsling)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("846b0511-a3ee-4e5b-a1ca-ac7bd1a21555"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Firearm.ID);
            builder.AddOr(Guid.Parse("eeea0252-3922-4639-8edd-f6dd52a69531"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("ca5082a1-79ee-4f1e-997c-ac2b2106930e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("ce1bd755-6e65-4fab-a16d-9b63ec87dc29"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            });
            builder.Manual(Guid.Parse("720c8402-9c78-4e9d-b8c0-07e922b366ae"), "You own a beast gun and have slain the type of creature associated with your beast gun in a fair hunt.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72555d7d-7392-4f98-b57a-0ff75ffc264d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
