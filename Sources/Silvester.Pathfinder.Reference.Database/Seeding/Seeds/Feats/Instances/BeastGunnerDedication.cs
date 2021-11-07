using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastGunnerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("765e93da-1fd6-4c26-ae5b-cfcef41a0d8f");

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
            yield return new TextBlock { Id = Guid.Parse("ee418a74-6801-45af-b369-57e2dcba095e"), Type = TextBlockType.Text, Text = "You’ve bonded to your beast gun and unlocked the first hints of its hidden potential. You treat all beast guns as martial firearms when determining your proficiency with them, even beast guns that are normally advanced weapons. You can change your bonded beast gun to another beast gun you own each day during your daily preparations, as long as you’ve previously performed a ritual hunt associated with the new beast gun." };
            yield return new TextBlock { Id = Guid.Parse("8db117d3-9c35-434f-968f-03cf4e6201f7"), Type = TextBlockType.Text, Text = "The beast gun also acts as a conduit, drawing out and amplifying any latent or active magic power you have. You learn to cast spontaneous spells and gain the (activity: Cast a Spell) activity. You gain a spell repertoire with one cantrip of your choice, from either the arcane or primal spell list. You choose this cantrip from the common spells on your chosen spell list or from other spells you have access to on the list. This cantrip must require a spell attack roll. You’re trained in spell attack rolls and spell DCs for arcane or primal spells, whichever of the two traditions you chose. Your key spellcasting ability for these spells is Charisma." };
            yield return new TextBlock { Id = Guid.Parse("15c72996-1862-43dd-a65f-8e05e1d9fdad"), Type = TextBlockType.Text, Text = "If you already cast arcane or primal spells from spell slots, you learn one additional cantrip from that tradition. If you’re a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you’re a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("43172982-93a9-4919-8b26-17e58bb07e21"), Type = TextBlockType.Text, Text = "You also gain (feat: Spellsling)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("27e25d5a-4b3a-4c1d-9e78-e6836be075e7"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Firearm.ID);
            builder.AddOr(Guid.Parse("02c2f823-3375-4a11-a848-2cf31118e556"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("50786e00-be42-438c-9850-7aac722b601d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("1ac1c27e-828c-418e-a1d4-bb11249fe5f2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            });
            builder.Manual(Guid.Parse("7d2ba362-1daa-4047-b0df-fc4ff6bc532e"), "You own a beast gun and have slain the type of creature associated with your beast gun in a fair hunt.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("234c56b4-0d33-4b60-b237-1a43bf2711c3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
