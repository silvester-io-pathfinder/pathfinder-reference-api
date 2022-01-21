using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedSchoolSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("508f4fd2-b843-402f-b2d6-d07f33da252e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced School Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("182e5808-5566-43f1-b5df-986acd9730ed"), Type = TextBlockType.Text, Text = $"You gain access to a powerful new school spell depending on your arcane school. If you're an abjurer, you gain {ToMarkdownLink<Models.Entities.Spell>("energy absorption", Spells.Instances.EnergyAbsorption.ID)}; if you're a conjurer, you gain {ToMarkdownLink<Models.Entities.Spell>("dimensional steps", Spells.Instances.DimensionalSteps.ID)}; if you're a diviner, you gain {ToMarkdownLink<Models.Entities.Spell>("vigilant eye", Spells.Instances.VigilantEye.ID)}; if you're an enchanter, you gain {ToMarkdownLink<Models.Entities.Spell>("dread aura", Spells.Instances.DreadAura.ID)}; if you're an evoker, you gain {ToMarkdownLink<Models.Entities.Spell>("elemental tempest", Spells.Instances.ElementalTempest.ID)}; if you're an illusionist, you gain {ToMarkdownLink<Models.Entities.Spell>("invisibility cloak", Spells.Instances.InvisibilityCloak.ID)}; if you're a necromancer, you gain {ToMarkdownLink<Models.Entities.Spell>("life siphon", Spells.Instances.LifeSiphon.ID)}; and if you're a transmuter, you gain {ToMarkdownLink<Models.Entities.Spell>("shifting form", Spells.Instances.ShiftingForm.ID)}. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("6acf9a8c-b0ad-4560-9fc9-88ece19e366a"), ClassFeatures.Wizards.ArcaneSchool.ID);
            builder.HaveAnyMagicSchool(Guid.Parse("1d32b1e0-296b-4a07-8450-bf367c7f10ce"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3147c74-0e9d-4664-9f30-91cdda8e9183"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
