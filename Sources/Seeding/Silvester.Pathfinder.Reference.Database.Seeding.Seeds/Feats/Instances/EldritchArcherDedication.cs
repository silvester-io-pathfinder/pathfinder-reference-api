using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchArcherDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("3d72ae5e-fd53-4bdd-8006-89fd91c1d91b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Archer Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the eldritch archer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c30eb132-cd03-4692-b306-a40c994305fd"), Type = TextBlockType.Text, Text = $"You blend magic with your archery, leading to powerful results. If you don't already cast spells from spell slots, you learn to cast spontaneous spells and gain the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You gain a spell repertoire with one cantrip of your choice, from a spell list of your choice. You choose this cantrip from the common spells on your chosen spell list or from other spells to which you have access on that list. This cantrip must require a spell attack roll. You're trained in spell attack rolls and spell DCs for that tradition. Your key spellcasting ability for these spells is Charisma." };
            yield return new TextBlock { Id = Guid.Parse("6ca2deeb-e2ec-4262-840c-1885b3ac4f44"), Type = TextBlockType.Text, Text = $"If you already cast spells from spell slots, you learn one additional cantrip from that tradition. If you're a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you're a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("6e65679e-a0db-4834-9260-6d5ed6fe1b4d"), Type = TextBlockType.Text, Text = $"You also gain {ToMarkdownLink<Models.Entities.Feat>("Eldritch Shot", Feats.Instances.EldritchShot.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("1d87a4f2-a33c-4fc4-b44b-c9e7471d8eaa"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Bow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aaf18da1-1b3f-4729-8037-d5f317ff7a9a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
