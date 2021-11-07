using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SunderSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("6e7c4b7a-506b-4cac-8ce1-fdde738cd388");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sunder Spell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7137864c-9403-4f41-8339-d70da658331a"), Type = TextBlockType.Text, Text = "You draw upon your superstitious fury to destroy a spell. Make a (action: Strike) with a melee weapon or an unarmed attack against a creature, object, or a spell manifestation (such as the wall created by (spell: wall of fire) or the guardian from (spell: spiritual guardian)). If your (action: Strike) hits, you can attempt to counteract a single spell or magical effect on the target. Your counteract level for this attempt is equal to half your level rounded up, and you use the result of your attack roll for the counteract check." };
            yield return new TextBlock { Id = Guid.Parse("e176b4e3-98d1-4eff-ab62-37742bf21e17"), Type = TextBlockType.Text, Text = "Whether or not you succeed at your (action: Strike), the target becomes temporarily immune to your Sunder Spell for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("b8f517db-6544-4216-904a-25e182024d59"), Instincts.Instances.Superstition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b5993b7-a608-4454-bbf6-739e71c70cb4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
