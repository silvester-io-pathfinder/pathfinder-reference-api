using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedOverdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("c011a909-2c16-40f6-b227-795b8dc8ac67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Overdrive",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e6990b5-57bd-499c-9884-23b84d777043"), Type = TextBlockType.Text, Text = $"You've experimented enough on your teammates to transfer a substantial number of powered-up gizmos to them, enabling one of your allies to benefit from the full effects and duration of your {ToMarkdownLink<Models.Entities.Feat>("Overdrive", Feats.Instances.Overdrive.ID)}. The first time you use {ToMarkdownLink<Models.Entities.Feat>("Overdrive Ally", Feats.Instances.OverdriveAlly.ID)} during a given {ToMarkdownLink<Models.Entities.Feat>("Overdrive", Feats.Instances.Overdrive.ID)}, the effect lasts for the remainder of the duration of your {ToMarkdownLink<Models.Entities.Feat>("Overdrive", Feats.Instances.Overdrive.ID)}, instead of just until the end of the target's next turn. Any further uses of {ToMarkdownLink<Models.Entities.Feat>("Overdrive Ally", Feats.Instances.OverdriveAlly.ID)} during the same {ToMarkdownLink<Models.Entities.Feat>("Overdrive", Feats.Instances.Overdrive.ID)} have their normal duration, per {ToMarkdownLink<Models.Entities.Feat>("Overdrive Ally", Feats.Instances.OverdriveAlly.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e1e40381-6629-44bb-b643-d8ae024e02d2"), Feats.Instances.OverdriveAlly.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7fe2f42-d534-482c-ae8d-46cdd6c16e55"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
