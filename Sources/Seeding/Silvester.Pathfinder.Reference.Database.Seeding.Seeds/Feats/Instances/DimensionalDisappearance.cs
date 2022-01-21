using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DimensionalDisappearance : Template
    {
        public static readonly Guid ID = Guid.Parse("2256bad9-4ebc-4c90-b3f0-52f1e75f3feb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dimensional Disappearance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b5dde78-57f3-4c8c-9f5a-1098036b8939"), Type = TextBlockType.Text, Text = $"You take advantage of teleportation to better hide your position. When you cast {ToMarkdownLink<Models.Entities.Spell>("dimensional assault", Spells.Instances.DimensionalAssault.ID)}, you're affected by an {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} spell at the end of the teleport. You can choose not to make the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that is normally part of {ToMarkdownLink<Models.Entities.Spell>("dimensional assault", Spells.Instances.DimensionalAssault.ID)}. If you do make the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, your {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} ends after the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, as normal for {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("73c996e8-8878-478f-9f78-056900cda9f7"), Spells.Instances.DimensionalAssault.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("e20473a5-8b92-4651-bcfe-6f85e1350fd4"), HybridStudies.Instances.LaughingShadow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("333c0ebd-de10-4acb-9e92-4ca0b865a4ea"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
