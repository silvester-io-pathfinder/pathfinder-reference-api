using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Philosophies.Instances
{
    public class EsotericOrderOfThePalatineEye : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Esoteric Order of the Palatine Eye",
                Edicts = "Seek out wisdom of ancient cultures (particularly Ancient Osirion), provide succor to scholars, honor the rites of the order.",
                Anathema = "Reveal the order’s secrets to those outside the organization (or even to insufficiently ranked members), destroy rare or ancient lore.",
                AreasOfConcern = "History, occultism, secret lore.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Based in Ustalav but active in aristocratic salons and cloistered academies across Avistan and Garund, the Esoteric Order of the Palatine Eye is a mystic order of occultist-nobles who seek philosophical self-awareness and mastery of celestial truths. The order was founded in 3988 AR when the gentleman-explorer Aldus Canter returned from the Osirian desert where he had been lost for 3 years. Aldus spoke of meeting a cult following a desiccated angel named Tabris. Tabris revealed the secret history of the multiverse and tasked Aldus with acting as a messenger of mystic secrets. Upon his return, Aldus gathered a coterie of his fellow Ustalavic nobles eager to plumb these secrets. His message was far from clear, however, consisting of garbled and coded texts in an untidy medley of Osirian mysticism, Pharasmin rites, and Varisian occult lore. Scouring Aldus’s texts—both those brought from Osirion and his many annotations and reinterpretations penned thereafter—has been the order’s primary activity for centuries, even before the increasingly erratic Aldus disappeared in 4028 AR. The Esoteric Order’s meticulous research has produced occult secrets and mystical rites known nowhere else on Golarion and hints at further secret lore for the enlightened. The order’s greatest accomplishment, however, was averting a doomsday few on Golarion will ever realize was imminent: in 4718 AR, the order’s greatest heroes prevented the planet Aucturn from devouring Golarion." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 97
            };
        }
    }
}
