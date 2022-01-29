using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnlimitedDemesne : Template
    {
        public static readonly Guid ID = Guid.Parse("1d3320ec-d4c1-46cb-9818-8d5363b7c449");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unlimited Demesne",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d5a323e-a807-42d1-835d-d70cafbbb5ff"), Type = TextBlockType.Text, Text = $"You can move your demesne from place to place, bringing it along wherever your journey takes you. Once per day, you can invoke your demesne and call it forth, in a process that takes 1 minute. This has the effects of {ToMarkdownLink<Models.Entities.Spell>("resplendent mansion", Spells.Instances.ResplendentMansion.ID)}, except that it conjures forth your demesne from its previous location, with all the benefits of Thaumaturge's Demesne in addition to the benefits of the spell. You must be able to claim the new area as your demesne, with the same restrictions as Thaumaturge's Demesne." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb70fce2-f6da-413d-bfed-95a86c0fa39e"), Feats.Instances.ThaumaturgesDemesne.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a36ba16-73e6-4910-bad4-8b685c2b47c2"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
