using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericLore : Template
    {
        public static readonly Guid ID = Guid.Parse("294334bf-bb42-46de-b4ad-d8b7d41381e0");

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
            yield return new TextBlock { Id = Guid.Parse("bdee34f6-305c-4ff6-9915-b8290634e1b0"), Type = TextBlockType.Text, Text = "Your diverse studies into various sources of lore mean you’ve heard rumors or theories about almost every topic... though admittedly, your sources aren’t always the most reliable. You are trained in Esoteric Lore, a special Lore skill that can be used only to (action: Recall Knowledge), but on any topic." };
            yield return new TextBlock { Id = Guid.Parse("16026b9f-fbfe-4271-8a5e-16dec1b186cf"), Type = TextBlockType.Text, Text = "If you have legendary proficiency in Arcana, Nature, Occultism, or Religion, you gain expert proficiency in Esoteric Lore, but you can’t increase your proficiency rank in Esoteric Lore by any other means." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fea7f5a0-ede4-4d09-b865-749ef97adb0e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
