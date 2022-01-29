using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VersatileSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3ec3719f-1925-4586-91df-c64e0dd64bb9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Versatile Spellstrike",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23b19ac8-5006-409f-8263-5ddc1b20e2c9"), Type = TextBlockType.Text, Text = $"You can channel the entire realm of possibilities of your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)} into an attack. Once during your daily preparations, you can use a spell slot to hold that infinite potential, rather than using it to prepare a spell. When you make a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}, you can expend this special spell slot to immediately prepare and cast a spell from your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)} at 2 levels lower than the slot's level. (As normal for preparing spells, you can use a spell of an even-lower level, heightening it accordingly.) You don't have any spell prepared in that slot until you cast from that slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dff6c24f-ce33-430e-8b45-e14e885534c6"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("182b7090-dca7-4cbb-a574-b52c9845ecd3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
