using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonArcana : Template
    {
        public static readonly Guid ID = Guid.Parse("b97cb40d-bc25-47d4-be47-5e7c101785ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Arcana",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6bdc45a4-a315-4a5f-854a-d45c94588ba4"), Type = TextBlockType.Text, Text = $"You've discovered how to add the magic of dragons to your tradition. Add the draconic bloodline's granted spells to your spell list; you must still learn them or add them to your repertoire as normal. These spells are {ToMarkdownLink<Models.Entities.Spell>("shield", Spells.Instances.Shield.ID)}, {ToMarkdownLink<Models.Entities.Spell>("true strike", Spells.Instances.TrueStrike.ID)}, {ToMarkdownLink<Models.Entities.Spell>("resist energy", Spells.Instances.ResistEnergy.ID)}, {ToMarkdownLink<Models.Entities.Spell>("haste", Spells.Instances.Haste.ID)}, {ToMarkdownLink<Models.Entities.Spell>("spell immunity", Spells.Instances.SpellImmunity.ID)}, {ToMarkdownLink<Models.Entities.Spell>("chromatic wall", Spells.Instances.ChromaticWall.ID)}, {ToMarkdownLink<Models.Entities.Spell>("dragon form", Spells.Instances.DragonForm.ID)}, {ToMarkdownLink<Models.Entities.Spell>("mask of terror", Spells.Instances.MaskOfTerror.ID)}, {ToMarkdownLink<Models.Entities.Spell>("prismatic wall", Spells.Instances.PrismaticWall.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("overwhelming presence", Spells.Instances.OverwhelmingPresence.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
            builder.HaveSpecificFeat(Guid.Parse("3c11693d-1e14-488a-be2c-90cb0ebb57a1"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79c07bd2-1422-469c-9f1d-80e23d4edd92"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
