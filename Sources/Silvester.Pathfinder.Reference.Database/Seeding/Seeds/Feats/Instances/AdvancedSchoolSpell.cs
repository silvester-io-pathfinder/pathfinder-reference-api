using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedSchoolSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("38d6aa98-df88-4e1d-a573-643753eed665");

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
            yield return new TextBlock { Id = Guid.Parse("f3cc2fb3-e552-4b88-a3d7-d46ab501629f"), Type = TextBlockType.Text, Text = "You gain access to a powerful new school spell depending on your arcane school. If you’re an abjurer, you gain (Spell: energy absorption); if you’re a conjurer, you gain (Spell: dimensional steps); if you’re a diviner, you gain (Spell: vigilant eye); if you’re an enchanter, you gain (Spell: dread aura); if you’re an evoker, you gain (Spell: elemental tempest); if you’re an illusionist, you gain (Spell: invisibility cloak); if you’re a necromancer, you gain (Spell: life siphon); and if you’re a transmuter, you gain (Spell: shifting form). Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("eca35ea3-7ced-44bd-bf66-e8c4c1c1d352"), ClassFeatures.Wizards.ArcaneSchool.ID);
            builder.HaveAnyMagicSchool(Guid.Parse("42144690-62dd-4f19-a92f-342f426b65c3"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15dbfa4d-966c-48ca-9c75-d18f7dfb40a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
