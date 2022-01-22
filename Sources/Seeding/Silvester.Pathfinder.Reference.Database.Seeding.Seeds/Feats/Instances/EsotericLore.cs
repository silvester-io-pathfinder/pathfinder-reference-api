using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericLore : Template
    {
        public static readonly Guid ID = Guid.Parse("de5ab8c7-cb63-4462-9ecb-260087810433");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d854ba9-136c-4a07-b8f5-8b715399317c"), Type = TextBlockType.Text, Text = $"Your diverse studies into various sources of lore mean you've heard rumors or theories about almost every topic... though admittedly, your sources aren't always the most reliable. You are trained in Esoteric Lore, a special Lore skill that can be used only to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}, but on any topic." };
            yield return new TextBlock { Id = Guid.Parse("043aa15a-420e-4581-9b41-b409b2328e68"), Type = TextBlockType.Text, Text = $"If you have legendary proficiency in Arcana, Nature, Occultism, or Religion, you gain expert proficiency in Esoteric Lore, but you can't increase your proficiency rank in Esoteric Lore by any other means." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("050033ce-c855-4113-b1cf-64d336b6c6d2"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
